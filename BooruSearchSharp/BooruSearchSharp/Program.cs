using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml;
using System.Net;
using System.Xml.Serialization;
using BooruSearchSharp.Gel;
using BooruSearchSharp.R34;
using BooruSearchSharp.Safebooru;
using BooruSearchSharp.FurryBooru;

namespace BooruSearchSharp
{
    class Program
    {
        public static void Main (string[] args) => new Program ().Start ();

        void Start ()
        {
            Console.WriteLine ("Program Entered.\n\n\n");
            //var sb = new SearchBooru.SearchBooru ();
            //var db = new DanBooru.DanBooru ();
            //var yd = new Yandere.Yandere ();
            //var kc = new Konachan.Konachan ();
            //var lb = new Lolibooru.Lolibooru ();
            //var dlb = new DelishBooru.DelishBooru ();
            //var e62 = new E621.E621 ();
            //var ub = new UberBooru.UberBooru ();
            //var bb = new BroniBooru ();
            //var td = new TheDoujin ();
            //var gel = new GelBooru ();
            //var safe = new SafeBooru ();
            //var r34 = new Rule34 ();
            //var fb = new FurryBooru.FurryBooru ();
            //var xb = new XBooru ();
            Console.ReadKey ();
        }
    }
}
