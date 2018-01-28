﻿using KuMaDaoCoreAbp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 100;
            var b = 100;
            Console.WriteLine(a +b +1);
            // var db = CreateDbcontext();

            //var cc = db.Article.ToList();
            //检查迁移
            // CheckMigrations();


            //Test1();
            //Test2();
            //Program.Test3(); Program.Test3();
           
           
        }


        static KuMaDaoCoreAbpDbContext CreateDbcontext()
        {
            var builder = new DbContextOptionsBuilder<KuMaDaoCoreAbpDbContext>();        
            KuMaDaoCoreAbpDbContextConfigurer.Configure(builder, "Data Source=SJNI5QAZX1FLUPM\\JSQL2008;Initial Catalog=test;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return new KuMaDaoCoreAbpDbContext(builder.Options);
        }
        static void CheckMigrations()
        {
            var db = CreateDbcontext();
            Console.WriteLine("Check Migrations");

            //判断是否有待迁移
            //if (db.Database.GetPendingMigrations().Any())
            //{
                Console.WriteLine("Migrating...");
                //执行迁移
                db.Database.Migrate();
                Console.WriteLine("Migrated");
            //}
            Console.WriteLine("Check Migrations Coomplete!");
        }

        static void Test1()
        {
            var a = "123";
            Console.WriteLine(a);
            var b = a;
            b = "1233";
            Console.WriteLine(a);

        }
        static void Test2()
        {
            var a = "123";
            Console.WriteLine(a);
            var b = a;
            a = "1233";
            Console.WriteLine(b);

        }

        static void Test3(string a = "12323")
        {
            a += "6";
            Console.WriteLine(a);
        }


    }
}
