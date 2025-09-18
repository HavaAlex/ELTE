#include <stdio.h>
#include <stdbool.h> //bool true false
#include <limits.h>//INT_MIN,INT_MAX
#include <math.h>

int main(){
    //1
    printf("================================\n");
    printf("1. feladat (pozitiv negativ vagy nulla)\n");
    int num1 = 0;
    printf("Adjon meg egy szamot: ");
    scanf("%d",&num1);
    if(num1>0){
        printf("Az on szama (%d) pozitiv!\n",num1);
    }
    else{
        if(num1==0){
            printf("Az on szama (%d) nulla!\n",num1);
        }
        else{
            printf("Az on szama (%d) negativ!\n",num1);
        }
    }
    printf("================================\n");

    //2
    printf("================================\n");
    printf("2. feladat (kiiras gyak.)\n");
    printf("%cHello%c\n%cWorld%c\n",34,34,34,34);
    printf("================================\n");


    //3
    printf("================================\n");
    printf("3. feladat (szam megforditasa)\n");
    int num3 = 0;
    printf("Adjon meg egy szamot: ");
    scanf("%d",&num3);
    int result3 = 0;
    while (num3 != 0)
    {
        result3 = result3*10;
        result3 += num3%10;
        num3 = num3/10;  
    }
    printf("visszafele %d\n",result3);
    printf("================================\n");


    //4
    printf("================================\n");
    printf("4. feladat (szam osztoinak kiirasa)\n");
    int num4 = 0;
    printf("Adjon meg egy szamot: ");
    scanf("%d",&num4);
    printf("Az on szamanak (%d) osztoi a kovetkezok: ",num4);
    for (int i = num4; i > 0; i--)
    { 
        if(num4%i==0){
            printf(" %d ",i);
        }
    }
    printf("\n");
    printf("================================\n");


    //5
    printf("================================\n");
    printf("5. feladat (legnagyobb kozos oszto)\n");

    int num5a = 0 ;
    int num5b = 0;
    printf("Adjon meg egy szamot: ");
    scanf("%d",&num5a);
    printf("Adjon meg még egy szamot: ");
    scanf("%d",&num5b);

    if(num5a> num5b){
        for (int i = num5a; i > 0; i--)
        {
            if(num5a%i==0 && num5b%i==0){
                printf("A ket szam legnagyobb kozos osztolya: %d\n",i);
                break;
            }
        }
    }
    else{
        for (int i = num5b; i > 0; i--)
        {
            if(num5a%i==0 && num5b%i==0){
                printf("A ket szam legnagyobb kozos osztolya: %d\n",i);
                break;
            }
        }
    }

    printf("================================\n");


    //6
    printf("================================\n");
    printf("6. feladat (szorzotabla)\n");

    for (int i = 1; i < 11; i++)
    {

        for (int j = 1; j < 11; j++)
        {
            int szorzat = i*j;
            printf("%d\t",szorzat);
        }
        printf("\n");
    }
    printf("================================\n");


    //7
    printf("================================\n");
    printf("7. feladat (sakktabla)\n");

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if(i%2==0){
                if(j%2==0){
                    printf("[]");
                }
                else{
                    printf("  ");
                }
            }
            else{
                if(j%2==1){
                    printf("[]");
                }
                else{
                    printf("  ");
                }
            }
        }
        printf("\n");
        
    }
    printf("================================\n");



    //10
    printf("================================\n");
    printf("10. feladat (palindrom - e) \n");
    int num10 = 0;
    printf("Adjon meg egy szamot: ");
    scanf("%d",&num10);
    int tempnum10 = num10;
    int result10 = 0;
    while (tempnum10 != 0)
    {
        result10 = result10*10;
        result10 += tempnum10%10;
        tempnum10 = tempnum10/10;  
    }
    if(num10 == result10){
        printf("Igen a %d palindrom\n",num10);
    }
    else{
        printf("Ez nem nyert\n");
    }
    
    printf("================================\n");
    return 0;
}