//Calculadora IMC 
bool continuar = true;
while (continuar){
    
    Console.WriteLine("Qual é o seu nome?");
    string nome = Console.ReadLine();

    Console.WriteLine("Qual é a sua idade?");
    int idade = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Qual é o seu altura?");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Qual é o seu peso?");
    double peso = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);


    if (imc <= 18.5){
        Console.WriteLine("abaixo do peso");
    }

    else if(imc > 18.6 && imc <= 24.9)
    {
        Console.WriteLine("Peso ideal");
    }
    else if(imc >= 25.0 && imc <= 29.9){
        Console.WriteLine("Levemente acima do peso");
    }
    else if(imc >= 30.0 && imc <= 34.9){
        Console.WriteLine("Obesidade I");
    }
    else if(imc >= 35.0 && imc <= 39.9){
        Console.WriteLine("Obesidade II");
    }
    else if(imc >= 40){
        Console.WriteLine("Obesidade III");
    }

    Console.WriteLine("Qual é a sua faixa Etaria?");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age <= 12)
    {
        Console.WriteLine("Criança");
    } 
    else if (age >= 13 && age <= 18)
    {
        Console.WriteLine("Adolescente");
    }
    else if (age >= 19 && age <= 59)
    {
        Console.WriteLine("Adulto");
    }
    else if (age >= 60)
    {
        Console.WriteLine("Idoso");
    } 

            Console.WriteLine("\nRelatório:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("IMC: " + imc);
            Console.WriteLine("Faixa Etária:" + age);

Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (S/N): ");
string resposta = Console.ReadLine();
            continuar = (resposta == "s");

           
}

