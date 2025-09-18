#include <stdio.h>
#include <stdbool.h> //bool true false
#include <limits.h>//INT_MIN,INT_MAX
#include <math.h>
int main()
{
    printf("Hello World!\n");
    int num = 42069;
    printf("A szam kezdeti erteke: %d\n",num);

    const int num2 = 696969;
    printf("A szam2 kezdeti erteke: %d\n",num2);
    if(num2%2==1){
        printf("YEHAAAA NOW THATS MY BOY\n");
    }
    else{
        printf("Nembaj megoldom igy is \n");
    }
    (num2%2==1) ? printf("YEHAAAA NOW THATS MY BOY\n") : printf("Nembaj megoldom igy is\n ");

    int num4 = 0;
    printf("Kerek egy paratlan szamot! : ");
    scanf("%d",&num4);
    while(num4 % 2 ==0){
        printf("Hiba ! Kerek egy paratlan szamot! : ");
        scanf("%d",&num4);
    }
    printf("Csak osszejott\n");


   /* do{

    }while();*/
    int num5 = 7 ;
    printf("Az egész: %d\n",num5);
    num5 = 7.7;
    printf("Az valós: %d\n",num5);
    num5 = true;
    printf("A logikai : %d\n",num5);
    num5 = 'a';
    printf("A karakter : %d\n",num5);
    //num5 = "abc";
    //printf("A string : %d\n",num5);
//nagyon csúnya dolog ez ne csináljad légysziii 
    for (float i = 0.0; i <= 1.0; i+=0.1)
    {
        printf("%.10f\n",i);
    }
    printf("\n");
    printf("ez mar viszont tok jo");
    for (int i = 0; i < 11; i++)
    {
        //printf("%.10f\n",i);
        printf("%d\n",i);
    }
    
    int n = 0;
    printf("Az int merete : %lld \n ",sizeof(n));
    printf("Abrazolhato max min ertek: %d-tol , %d-ig\n",INT_MIN,INT_MAX);
    int min = -pow(2,31); 
    int max = pow(2,31)-1; // -1 a nullábak
    printf("Abrazolhato max min ertek: %d-tol , %d-ig\n",min,max);
    printf("max+10: °%d\n",max+10);
    unsigned int u = max+10;
    printf("max+10: °%u\n",u);

    return 0;
}
