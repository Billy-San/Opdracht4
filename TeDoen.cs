using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class TeDoen
    {
            private int Id { get; set; }
            private static int count = 0;
            private DateTime? TijdStip { get; set; }
            private string Title { get; set; }
            private string[] Info;
            private string text;
            private string[] lines;

            public TeDoen (DateTime tijdStip, string title, string[] informatie)
            {
                if (tijdStip >= DateTime.Now)
                {
                    TijdStip = tijdStip;
                }
                else
                {
                    TijdStip = null;
                }

                Title = title;
                Info = informatie;
                count++;
                Id = count;
            }

            public override string ToString()
            {
                string result = "";
                if (TijdStip != null)
                {
                    return "id " + Id + " title: " + Title + " information: " + result;
                }
                else
                {
                    return "id " + Id + " tijdstijd: " + TijdStip + " title: " + Title + " information: " + result;
                }
            }


        }
}
