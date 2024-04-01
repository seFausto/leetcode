// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

var s = new RegularExpressionMatching();

var r = s.IsMatch("ab", ".*c");

Console.WriteLine(r);

