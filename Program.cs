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

while(xis < 9){



    if(xis == 0 || xis == 2 || xis == 4 || xis == 6 || xis == 8){
        jogador = "X";
    } else{
        jogador = "O";
    }

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
    break;
}

}


Console.WriteLine($"\n  {first}  |  {second}  |  {third}  ");
Console.WriteLine($"-----|-----|-----");
Console.WriteLine($"  {fourth}  |  {fifth}  |  {sixth}  ");
Console.WriteLine($"-----|-----|-----");
Console.WriteLine($"  {seventh}  |  {eighth}  |  {ninfh}  ");

Console.WriteLine($"\n{jogador} venceu");