using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private List<String> Lex(String str)
        {
            return str.Split(' ').Select(s => s.Trim()).ToArray().Where(s => s.Length > 0).ToList();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            if (rtxInput.Text.Trim() != "")
            {
                var tokens = Lex(rtxInput.Text);
                var parserOutput = parse(tokens);
                rtxOutput.Text = "Output from Lexer:\n" + "[" + String.Join(", ", tokens) + "]";
                rtxOutput.Text += "\nOutput from Parser:\n" + Newtonsoft.Json.JsonConvert.SerializeObject(parserOutput);
                rtxOutput.Text += "\nOutput from Transpiler:\n" + transpile(parserOutput);
            }
        }

        struct AST
        {
            public SymbolTypes type;
            public String val;
            public List<AST> expr;
        };


        enum SymbolTypes { Number, Operator };

        private AST parse(List<String> tokens)
        {
            int c = 0;
            Func<String> peek = () => tokens[c];
            Func<String> consume = () => tokens[c++];

            AST parseExpr()
            {
                Func<AST> parseNum = () => new AST() { type = SymbolTypes.Number, val = consume(), expr = null };

                Func<AST> parseOp = () =>
                {
                    AST node = new AST { val = consume(), type = SymbolTypes.Operator, expr = new List<AST>() };
                    bool next = true;
                    while (next) { 
                        node.expr.Add(parseExpr()); 
                   
                        try
                        {
                            peek();
                            next = true;
                        } catch(ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                            next = false;
                        }
                    };
                    return node;
                };

                return new Regex(@"^\d+$").Match(peek()).Success ? parseNum() : parseOp();
            }
            return parseExpr();
        }

        private String transpile(AST ast)
        {
            Dictionary<String, char> OpMap = new Dictionary<string, char>() { { "sum", '+'}, { "mul", '*' }, {"sub", '-' }, {"div", '/'}};

            Func<AST, String> transpileNode = null;
            transpileNode = (subast) =>
            {
                Func<AST, String> transpileNum = (node) => node.val;
                Func<AST, String> transpileOp = (node) =>
                {
                    Console.WriteLine("Node: " + Newtonsoft.Json.JsonConvert.SerializeObject(node));
                    String t = node.expr[0].type == SymbolTypes.Number ? "Number" : "Operator";
                    Console.WriteLine("Node Type:" + t);
                    String[] sa = node.expr.Select(s => transpileNode(s)).ToArray<string>();
                    Console.WriteLine("TEST: " + Newtonsoft.Json.JsonConvert.SerializeObject(sa));
                    return $"({String.Join(" " + OpMap[node.val] + " ", sa)})";
                };
                return subast.type == SymbolTypes.Number ? transpileNum(subast) : transpileOp(subast);
            };
            return transpileNode(ast);
        }



    }

   
}
