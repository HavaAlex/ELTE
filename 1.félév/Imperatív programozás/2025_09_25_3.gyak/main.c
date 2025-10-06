#include <stdio.h>
#include <stdbool.h>
#include <ctype.h> //karatekerk cuccai
 
void operator( void ){ //ures parameter lista
    int i = 6;   
    int j = ++i;
    printf("Prefix (j=++i) i=%d, j=%d\n",i,j); //incrementált értéket változtatja meg

    i = 6;   
    j = i++;
    printf("Postfix (j=i++) i=%d, j=%d\n",i,j); //előszőr j = 6 aztán lesz csak i++
}

void little_big( void );


void basic_math(int n , int m){
    printf("A ket szam osszege: %d \n",n+m);     
    printf("A ket szam kulonbsege: %d \n",n-m);          
    printf("A ket szam szorzata: %d \n",n*m); 
    float osztva =n/(float)m  ;              
    printf("A ket szam elosztva: %.2f \n",osztva);                                                                                                                                                                                                                                                                                                                        
}
void circle_attributes(int r){
    int d = r*2;
    float k = 2*r*3.14; 
    float t = r*r*3.14;
    printf("Az on korenek az atmeroje : %d \n", d);
    printf("Az on korenek a kerulete : %.2f \n", k);
    printf("Az on korenek a terulete : %.2f \n", t);
}

void formatDate(int t){
    int day = 0;
    int month = 0;
    int year = 0;
    year = t%10000;
    month = (t%1000000-year)/10000;
    day = (t -year-month)/1000000;
    
    printf("ev:: %d \n", year);
    printf("honap:: %d \n", month);
    printf("nap:: %d \n",day);
    
    

}


void intSwap(int a, int b)
{
    printf("a: %d\n",a);
    printf("b: %d\n",b);
    /*a = a^b;
    b = a^b;
    a = a^b;*/
    a = a + b;
    b = (b-a)*-1;
    a = a - b;

    printf("a: %d\n",a);
    printf("b: %d\n",b);

}

void bitSwap(int a){
    //int bits = ~a;
    printf("a = %u\n", a);
    printf("~a = %u\n", a = ~a);
    //printf("%d\n",bits);
}
int main(){
    
    operator();/*
    //operator(42); //némely fordito  nem szeretja be 
*/
    //little_big();
    int a=0, b=0;
    printf("Kerek ket szamot! ");
    int units = scanf("%d %d", &a,&b); // sikeres beolvasások száma 
    printf("%d adat beolvasva.\n",units);
    printf("a=%d, b=%d\n",a,b);


    //Önálló munka jön
    //3
    basic_math(a,b);
    int r = 0;
    printf("Adja meg egy tetszoleges kor sugarat: ");
    scanf("%d",&r);

    //4
    circle_attributes(r);


    //5
    int datum = 0;
    printf("Adjon meg egy datumot egybeirva (DD-MM-YYYY): ");
    scanf("%d",&datum);
    formatDate(datum);

    //6

    //7
    int e, q= 0;
    printf("Adjon meg 2 szamot amiket majd felcserelek: ");
    scanf("%d %d",&e,&q);
    intSwap(e,q);

    //8 bitcsere (igazából palindrom)
    int o = 8;
    bitSwap(o);

    return 0;
}

void little_big( void )
{
    char l;

    do{
        printf("Kerem adjon meg betuket! : ");
        scanf(" %c",&l);
        /*
        scanf(" %c",&l);   //space elötte: ignore whitespaces  | space utána: 
        scanf("%c",&l);    //normal
        scanf("%c ",&l);   //space utána: ignore until not whitespace
        */

        if( isalpha(l)){

            printf("A megadott betu %c\n",l);
            if( isupper(l) ) printf("Kicsinyitve %c\n\n",tolower(l));
            if( islower(l) ) printf("Nagyitva %c\n\n",toupper(l));
        }
        else if ( l != '0'){
            printf("Hiba! Nem Betu! \n");
        }

    }while( l != '0');
}