/*Programa para ller archivo de resultado de iracing archivo csv
"Fin Pos","Car ID","Car","Car Class ID","Car Class","Team ID","Cust ID","Name","Start Pos","Car #","Out ID","Out","Interval","Laps Led","Qualify Time","Average Lap Time","Fastest Lap Time","Fast Lap#","Laps Comp","Inc","League Points","Max Fuel Fill%","Weight Penalty (KG)","League Agg Points","AI"
    0         1       2        3            4           5         6        7        8        9        10      11       12        13          14             15  
Me interesa guardar: 
00 "Fin Pos"
07 "Name"

Que quiero que haga el programa:

- Leer el archivo de resultados del evento de iRacing y guardalor en un vector en memoria
- Leer el archivo de pilotos PRO y AM
- Recorrer el vector y ordenar los resultados en PRO y AM
- Otorgar Puntos de la carrera 
- torneo.csv  Leer posiciones del torneo y actualizar las posiciones con los nuevos resultados.

Flujo:
1. leo el archivo de resultado, con esto se cuantos pilotos corrieron

2. leo el archivo de pro-am para saber quienes son de cada categoria, separa un vector de pilotos para cada categoria

3. recorro el resultado y busco el piloto. 
   Guardo la posicion, categoria y piloto

4. separo los resultados en Pro y Am
   Los imprimo

5. Otorgar puntos de la carrera   

Puntos:   puntaje {0,30,26,23,21,19,17,15,13,11,12,10,9,8,7,6,5,4,3,2,1}
1  30
2  26
3  23
4  21
5  19
6  17
7  15
8  13
9  11
10 12
11 10
12 9
13 8
14 7
15 6
16 5
17 4
18 3
19 2 
20 1
*/

using System;
using System.IO;

namespace ProgramaMDS
{
    class MainClass
    {
        public struct Resultados
         {
           public int posicion;
           public string categoria;
           public string piloto; 

           public int puntos;     
         }

        public static void Main(string[] args)
        {
        string[] lineas = File.ReadAllLines("./resultados.csv");    //Leo Result y guardo todas las filas en un array de string "lineas"

        int[] puntaje = new int[] {0,30,26,23,21,19,17,15,13,11,12,10,9,8,7,6,5,4,3,2,1}; //tabla de puntales del [1] al [20]





        Resultados[] vectResultados = new Resultados[lineas.Length];

        string[] catPilotos = File.ReadAllLines("./pro-am.csv");    //Leo pro-am y guardo todas las filas en un array de string "catPilotos"
                                                                    // en catPilotos[0] >> PRO,Ariel Pacho,Tomas Anton,Andres Ruiz,Sebastián Gallego,Martin Facal,....
                                                                    // en catPilotos[1] >> AM,Maxi Cerrella,Luis Piloni,MR Mazza,Mattias Pascual,.....
          //Console.WriteLine(catPilotos[0]);
          var catPro = catPilotos[0].Split(',');                    //   catPro >> PRO,Ariel Pacho,Tomas Anton,Andres Ruiz,Sebastián Gallego,Martin Facal,....    
          // Console.WriteLine("Pilotos Pro son: " + catPro.Length);
          
          //Console.WriteLine(catPilotos[1]);                         //    catAm >> AM,Maxi Cerrella,Luis Piloni,MR Mazza,Mattias Pascual,.....
          var catAm = catPilotos[1].Split(','); 
          //Console.WriteLine("Pilotos Am son: " + catAm.Length);

          int i=0;
          int posPro=1;
          int posAm =1;

        foreach(var linea in lineas){
            var valores = linea.Split(',');
                 string strPiloto = valores[7].TrimEnd('"');    //Le saco las "" extras
                 strPiloto = strPiloto.TrimStart('"');
            
          
              
            for(int x=0; x<catPro.Length; ++x){           //recorre los pilotos Pro
              if(strPiloto==catPro[x]){
                  vectResultados[i].piloto=strPiloto;
                  vectResultados[i].posicion=posPro;
                  vectResultados[i].categoria="Pro";
                  vectResultados[i].puntos=puntaje[posPro];
                  posPro++;
              }  //cierro if 
            }    //cierro for


            for(int x=0; x<catAm.Length; ++x){           //recorre los pilotos Am
              if(strPiloto==catAm[x]){
                  vectResultados[i].piloto=strPiloto;
                  vectResultados[i].posicion=posAm;
                  vectResultados[i].categoria="Am";
                  vectResultados[i].puntos=puntaje[posAm];
                  posAm++;
              }  //cierro if 
            }    //cierro for

          i++; 
        }  // cierra el foreach

        
         for(i=0; i<lineas.Length;++i){
          Console.WriteLine(vectResultados[i].categoria + " - " + vectResultados[i].posicion + " - " + vectResultados[i].piloto + " - " + vectResultados[i].puntos + " ptos");
         }

        } //cierra el Void main
    } //Cierra la clase main
} //cierra el program

