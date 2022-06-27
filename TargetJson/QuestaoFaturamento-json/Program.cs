using System;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using TargetJson;
using System.Collections.Generic;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dadost.json");

		var obj = JsonConvert.DeserializeObject<List<DiaValor>>(json);

		Calculos a = new Calculos();

		Console.WriteLine(a.menorFatu(obj));
		Console.WriteLine(a.totalFatu(obj));
		
	}
}
