// See https://aka.ms/new-console-template for more information
var xis = 0;
var jogador = "";

var first = "1";
var second = "2";
var third = "3";
var fourth = "4";
var fifth = "5";
var sixth = "6";
var seventh = "7";
var eighth = "8";
var ninfh = "9";

var escolha = "0";
var vencedor = "0";

while(xis < 9){

await Task.Delay(500);

    if(xis == 0 || xis == 2 || xis == 4 || xis == 6 || xis == 8){
        jogador = "X";
    } else{
        jogador = "O";
    }

    Console.WriteLine($"\nVez de: {jogador}");

Console.WriteLine($"\n  {first}  |  {second}  |  {third}  ");
Console.WriteLine($"-----|-----|-----");
Console.WriteLine($"  {fourth}  |  {fifth}  |  {sixth}  ");
Console.WriteLine($"-----|-----|-----");
Console.WriteLine($"  {seventh}  |  {eighth}  |  {ninfh}  \n");

while(escolha != "1" && escolha != "2" && escolha != "3" && escolha != "4" && escolha != "5" && escolha != "6" && escolha != "7" && escolha != "8" && escolha != "9" ){
 Console.WriteLine("\nInsira onde você quer jogar:");   
 escolha = Console.ReadLine();
}

switch(escolha){
    case "1": 
        if(first == "X" || first == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "2": 
        if(second == "X" || second == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "3": 
        if(third == "X" || third == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "4": 
        if(fourth == "X" || fourth == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "5": 
        if(fifth == "X" || fifth == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "6": 
        if(sixth == "X" || sixth == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "7": 
        if(seventh == "X" || seventh == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "8": 
        if(eighth == "X" || eighth == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
    case "9": 
        if(ninfh == "X" || ninfh == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEsse espaço ja está prenchido"); 
            Console.ResetColor();
            escolha = "0";
        }
        break;
}

    switch(escolha){
    case "1": 
        first = jogador;
        break;
    case "2": 
        second = jogador;
        break;
    case "3": 
        third = jogador;
        break;
    case "4": 
        fourth = jogador;
        break;
    case "5": 
        fifth = jogador;
        break;
    case "6": 
        sixth = jogador;
        break;
    case "7": 
        seventh = jogador;
        break;
    case "8": 
        eighth = jogador;
        break;
    case "9": 
        ninfh = jogador;
        break;
}
    
xis += 1;

if((first == jogador && second == jogador && third == jogador) 
|| (fourth == jogador && fifth == jogador && sixth == jogador) 
|| (seventh == jogador && eighth == jogador && ninfh == jogador)
 || (first == jogador && fifth == fourth && seventh == jogador) 
 || (second == jogador && fifth == jogador && eighth == jogador) 
 || (third == jogador && sixth == jogador && ninfh == jogador) 
 || (first == jogador && fifth == jogador && ninfh == jogador) 
 || (fifth == jogador && fifth == jogador && seventh == jogador)){

    Console.WriteLine($"\n{jogador} venceu");
    vencedor = "sim";
    break;
}

escolha = "0";

}

if(vencedor != "sim"){
    Console.WriteLine("Deu velha");
}

Console.WriteLine($"\n  {first}  |  {second}  |  {third}  ");
Console.WriteLine($"-----|-----|-----");
Console.WriteLine($"  {fourth}  |  {fifth}  |  {sixth}  ");
Console.WriteLine($"-----|-----|-----");
Console.WriteLine($"  {seventh}  |  {eighth}  |  {ninfh}  ");
