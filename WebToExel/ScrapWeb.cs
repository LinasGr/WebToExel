using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebToExel
{
  class ScrapWeb
  {
    public List<Currency> table { get; }
    private HtmlDocument _doc;


    public ScrapWeb(string url)
    {
      table = new List<Currency>();
      _doc = new HtmlWeb().Load(url);
      if (_doc.DocumentNode.SelectNodes("//*[@id=\"content01\"]/div/div/div/table/tbody/tr[*]") != null)
        foreach (var line in _doc.DocumentNode.SelectNodes("//*[@id=\"content01\"]/div/div/div/table/tbody/tr[*]"))
        {
          if (line.ChildNodes.Count == 13)
          {
            table.Add(new Currency());
            table[table.Count - 1].Kodas = (line.SelectSingleNode("td[1]/b").InnerText);
            table[table.Count - 1].Valiuta = (line.SelectSingleNode("td[1]/b").NextSibling.InnerText.Substring(8).Trim());
            table[table.Count - 1].Buhalterinis_kursas =  line.SelectSingleNode("td[6]").InnerText.Trim().Replace(',','.');
          }
        }
    }
  }
}
