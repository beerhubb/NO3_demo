using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using No_3;

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>();
        // var cart = new List<Product>();

        var reader = System.IO.File.ReadAllLines(@"product.csv");
        // var tt = new StreamReader(File.OpenRead(@"D:\NO_3\product.csv"));
        // var li = tt.ReadLine
        // foreach (var item in reader)
        // {
        //     System.Console.WriteLine(item);
        // }
        var text = reader.Skip(1);
        foreach (var item in text)
        {
            var values = item.Split(','); // {SKU,Name,Price} => {p01, iPad Pro 11-inch, 23900}
            var goo = new Product
            {
                SKU = values[0],
                Name = values[1],
                Price = Double.Parse(values[2])
            };
            products.Add(goo);
        }
       
        // var all = products.Skip(1);
        //------------------------------------
        // foreach (var item in products)
        // {
        //     Console.WriteLine(item.Name);
        // }

        // var qry = all.FirstOrDefault(it => it.SKU == "p01");
        // System.Console.WriteLine(qry.SKU);
        var cart = new Homework09();
        var key = System.Console.ReadLine();
        var para = products.FirstOrDefault(it => it.SKU == key);
        System.Console.WriteLine(para.Name);
        System.Console.WriteLine(para.Price);
    }
}
