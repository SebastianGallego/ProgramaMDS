Programa para ller archivo de resultado de iracing archivo csv
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
Puntos:
1  80
2  67
3  57
4  50
5  44
6  40
7  37
8  34
9  32
10 30
11 28
12 26
13 24
