//criando o Vetor para armazenar os numeros
int[] numeros = new int[6];
//classe que gera os numeros
Random random = new Random();
//randomiza os numeros 
random.Next();
int aleatorio;
//for pra criar um laço de repetição para que seja gerado 6 numeros aleatorios
for(int c =0; c < 6; c++)
{
    //numeros aleatorios sendo criados e armazenados em uma classe os numeros gerados são de 1 a 60
    // ja que o comando Next ignora o ultimo valor então deve-se colocar um valor a mais para que o valor esteja correto
   aleatorio = random.Next(1, 61);
   //um loop while para evitar que os valores gerados aleatoriamente sejam iguais
   while(numeros.Contains (aleatorio))
   {
    //o loop while vai verificar se os valores se repetem e se repetir vai randomizar novamente
    aleatorio = random.Next(1,61);
   }
   //armazenando os valores em um vetor 
   numeros[c] = aleatorio;
    //mostrando os valores do vetor na tela dessa foram Ex: 1 2 3 4 5 6
   Console.Write(numeros[c] + " " );
   
}