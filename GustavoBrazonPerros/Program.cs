using System;

namespace fabGusPerros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa para saber la cantidad de alimento necesaria para su perro");
            Console.WriteLine("Ingrese la edad de su perro en meses: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Ingrese el peso de su perro en kg: ");
            
            int peso = Convert.ToInt32(Console.ReadLine());

            if(edad <= 12) {
                int comida = 0;
                Console.WriteLine("Su perro es cachorro");
                if(peso < 5) {
                    if(edad == 2) comida = 50;
                    if(edad == 3) comida = 60;
                    if(edad == 4) comida = 60;
                    if(edad == 5) comida = 60;
                    if(edad > 5) comida = 55;
                } else if(peso >= 5 && peso < 10) {
                    if(edad == 2) comida = 95;
                    if(edad == 3) comida = 110;
                    if(edad == 4) comida = 115;
                    if(edad == 5) comida = 115;
                    if(edad > 5) comida = 110;
                } else if(peso >= 10 && peso < 17) {
                    if(edad == 2) comida = 155;
                    if(edad == 3) comida = 185;
                    if(edad == 4) comida = 195;
                    if(edad == 5) comida = 190;
                    if(edad > 5) comida = 18;
                } else if(peso >= 17 && peso < 25) {
                    if(edad == 2) comida = 215;
                    if(edad == 3) comida = 265;
                    if(edad == 4) comida = 285;
                    if(edad == 5) comida = 285;
                    if(edad > 5) comida = 280;
                } else if(peso >= 25 && peso < 32) {
                    if(edad == 2) comida = 270;
                    if(edad == 3) comida = 350;
                    if(edad == 4) comida = 375;
                    if(edad == 5) comida = 375;
                    if(edad > 5) comida = 370;
                } else if(peso >= 32 && peso < 40) {
                    if(edad == 2) comida = 300;
                    if(edad == 3) comida = 400;
                    if(edad == 4) comida = 445;
                    if(edad == 5) comida = 450;
                    if(edad > 5) comida = 450;
                } else if(peso >= 40 && peso < 50) {
                    if(edad == 2) comida = 355;
                    if(edad == 3) comida = 475;
                    if(edad == 4) comida = 525;
                    if(edad == 5) comida = 530;
                    if(edad > 5) comida = 530;
                } else if(peso >= 50 && peso < 60) {
                    if(edad == 2) comida = 405;
                    if(edad == 3) comida = 545;
                    if(edad == 4) comida = 610;
                    if(edad >= 5) comida = 625;
                } else if(peso >= 60 && peso < 70) {
                    if(edad == 2) comida = 450;
                    if(edad == 3) comida = 605;
                    if(edad >= 4) comida = 685;
                } else if(peso >= 70 && peso < 90) {
                    if(edad == 2) comida = 485;
                    if(edad >= 3) comida = 670;
                } else if(peso >= 90) {
                    comida = 580;
                }

                Console.WriteLine("Su perro debe comer: " + comida + " gramos diarios");
            } else {
                Console.WriteLine("¿Cómo es la actividad de su perro? Seleccione una opción");
                Console.WriteLine("(1) Alta");
                Console.WriteLine("(2) Normal");
                Console.WriteLine("(3) Baja");
                int actividad = Convert.ToInt32(Console.ReadLine());
                string comida = "";

                Console.WriteLine("Su perro es Adulto");
                if(peso >= 2 && peso < 5) {
                    if(actividad == 1) comida = "60-115";
                    if(actividad == 2) comida = "55-100";
                    if(actividad == 3) comida = "45-85";
                } else if(peso >= 5 && peso < 10) {
                    if(actividad == 1) comida = "115-190";
                    if(actividad == 2) comida = "100-170";
                    if(actividad == 3) comida = "85-145";
                } else if(peso >= 10 && peso < 15) {
                    if(actividad == 1) comida = "190-255";
                    if(actividad == 2) comida = "170-225";
                    if(actividad == 3) comida = "145-195";
                } else if(peso >= 15 && peso < 25) {
                    if(actividad == 1) comida = "255-380";
                    if(actividad == 2) comida = "225-330";
                    if(actividad == 3) comida = "195-285";
                } else if(peso >= 25 && peso < 40) {
                    if(actividad == 1) comida = "380-535";
                    if(actividad == 2) comida = "330-475";
                    if(actividad == 3) comida = "285-410";
                } else if(peso >= 40 && peso < 55) {
                    if(actividad == 1) comida = "535-680";
                    if(actividad == 2) comida = "475-600";
                    if(actividad == 3) comida = "410-520";
                } else if(peso >= 55 && peso < 70) {
                    if(actividad == 1) comida = "680-820";
                    if(actividad == 2) comida = "600-720";
                    if(actividad == 3) comida = "520-620";
                } else if(peso >= 70) {
                    if(actividad == 1) comida = "820-985";
                    if(actividad == 2) comida = "720-870";
                    if(actividad == 3) comida = "620-750";
                }
                Console.WriteLine("Su perro debe comer en un rango de " + comida + " gramos diarios");
            }
        }
     }
}
