using System;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using TargetJson;
using System.Collections.Generic;
using System.IO;


public class Calculos
{
	public string menorFatu (List<DiaValor> obj)
	{
		
		double menor = 0;
		double maior = 0;

		for (int i = 0; i < obj.Count; i++)
		{
			if (i == 0)
			{
				menor = obj[i].valor;
				maior = obj[i].valor;
			}

			if (menor > obj[i].valor && obj[i].valor > 0)
			{
				menor = obj[i].valor;
			}
			if (maior < obj[i].valor)
            {
				maior = obj[i].valor;
            }

		}
		return $"Menor: {menor}, Maior: {maior}.";
	}

	
	public string totalFatu(List<DiaValor> obj)
	{
		double media = 0;
		int n = 0;
		double somaValores = 0;
		int qtd = 0;

		for(int i = 0; i < obj.Count; i++)
		{
			somaValores += obj[i].valor;

			if (obj[i].valor != 0)
			{
				qtd++;
				
			}	           
		}

		media = somaValores / qtd;

        for (int i = 0; i < obj.Count; i++)
        {
			if (obj[i].valor > media)
			{
				n++;
			}
		}
		return $"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: {n} dias.";
	}
}
