programa
{
	
	funcao inicio()
	{
		real janeiro,fevereiro,marco,abril,maio,junho,media,pix
		cadeia funcionario
		inteiro valor = 0

		escreva ("Digite o seu nome: ")
		leia(funcionario)
		escreva ("Digite suas vendas de janeiro: ")
		leia (janeiro)
		escreva ("Digite suas vendas de fevereiro: ")
		leia (fevereiro)
		escreva ("Digite suas vendas de marco: ")
		leia (marco)
		escreva ("Digite suas vendas de abril: ")
		leia (abril)
		escreva ("Digite suas vendas de maio: ")
		leia (maio)
		escreva ("Digite suas vendas de junho: ")
		leia (junho)

		media = (janeiro+fevereiro+marco+abril+maio+junho)/6

		escreva ("Sua média é:" + media)
		//média necessária = 150
		se (media >= 150){
			escreva ("\n" + "Parabéns! Você ganhou uma bonitifação de 10%")
		}
		senao {
			escreva ("\n" + "Infelizmente você não alcançou a média de vendas necessárias para ganhar a bonificação")
		}

		faca {
		escreva ("\n" + "Escolha como prefere receber sua bonificação: 1 - Dinheiro em espécie  2 - Pix   3 - Crédito na nossa loja")
		escreva ("\n" + "Sua escolha: ")
		leia (valor)

		escolha (valor){
			caso 1:
			escreva ("Ok! Você receberá sua bonificação em dinheiro em espécie")
			pare
			
			caso 2:
			escreva ("OK! Você receberá sua bonificação através do Pix. Digite sua chave pix:")
			leia (pix)
			pare
			
			caso 3:
			escreva ("Ok! Sua bonificação será convertida em créditos na nossa loja")
			pare
	
			caso contrario:
			escreva ("Você deve escolher entre as opções 1, 2 ou 3.")
			}
		}enquanto (valor >= 4)
		
	}

}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 0; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */