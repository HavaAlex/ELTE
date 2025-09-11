/*
dir
lis

mkdir új mappa
cp az a copy (cp main.c valamimasnev.c)
mv (move)  mv main2.c 'C:\Users\fxemow\Desktop\ELTE repo\1.félév\Imperatív programozás\2025_09_11_elsogyakorlat\'
rm main2.c

*/


#include <stdio.h> //standard io nem studio
#include <stdbool.h>
void main(){


 printf("Hello World!\n"); 
 int num = 69420999;
 printf("Ez egy szam: %d\n",num);
 //1
 printf("1.Feladat: =============================\n");
 printf("Havasi Alex Marton\n");
 //2
 printf("2.Feladat: =============================\n");
 int szamok[3];
 printf("Mutass egy szamot ocsipok ");
 scanf("%d", &szamok[0]);
 printf("Na megegyet ");
 scanf("%d", &szamok[1]);
 printf("Harom az igazi ");
 scanf("%d", &szamok[2]);
 int result = 1;
 for (int i = 0; i < 3; i++) {
   result = result * szamok[i];
 }
 printf("Ezt skubizd tesomsz %d\n",result);
 //3/a
 printf("3.Feladat (int): =============================\n");
 int osztandoint = 0;
 printf("Mutassal egy szamot: ");
 scanf("%d",&osztandoint);
 int osztoint = 0;
 printf("Ezzel elosztom neked: ");
 scanf("%d",&osztoint);
 float eredmeny = osztandoint / osztoint;
 printf("%.2f lett remelem elegedett vagy\n",eredmeny);


 //3/b
 printf("3.Feladat (float): =============================\n");
 float osztandof = 0.0;
 printf("Mutassal egy szamot: ");
 scanf("%f",&osztandof);
 float osztof = 0.0;
 printf("Ezzel elosztom neked: ");
 scanf("%f",&osztof);
 float eredmeny2 = osztandof / osztof;
 printf("%.2f lett remelem elegedett vagy\n",eredmeny2);
 //4
 printf("4.Feladat: =============================\n");
 float r ;
 float a;
 float b;
 printf("Kör sugara: ");
 scanf("%f",&r);
 printf("négyzet Egyik oldal: ");
 scanf("%f",&a);
 printf("négyzet Másik oldal: ");
 scanf("%f",&b);
 float tk = 2*r*3.1415;
 float tt = a * b;
 printf("Kör területe: %f\n",tk);
 printf("Téglalap terüéete: %f\n",tt);
 //5
 printf("5.Feladat: =============================\n");
 
 char name[5] = "Alex";
 printf("Szia %s\n",name);
 

}

//forditás
/*

gcc main.c exe-t csinál
.\a.exe futtatás
.\main.exe ez is
gcc -c main.c .o file-t csinálsz
gcc -o main main.c         exe file ez is/irsz felüé
-W -Wall -Wextra -pedantic
*/
