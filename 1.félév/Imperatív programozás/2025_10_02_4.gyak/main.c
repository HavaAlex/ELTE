#include <stdio.h>
#include <stdbool.h>
#include <limits.h>
#include <stdlib.h>
#include <time.h>

/*
void op_chain( void ){
    int num = 3;
    (2 < num < 4) ? printf("True\n") : printf("False\n"); // Ez igy nem lesz jó mert 2<num az true azaz 1 tehát < 4
    (4 > num > 2) ? printf("True\n") : printf("False\n"); // de itt az 1 azaz az igaz nem nagyobb mint 2
}
void decrement ( void ){
    //for (unsigned int i = 10; i>=0; i--) // végtelen ciklus
    //for (unsigned int i = 10; i<=10; i--) fura fetlétel
    for ( unsigned int i = 11; i>0; i--)
    {
        printf("%02d.: %d\n",11-i, i);
    }
    
}*/

void leap_year( void );

int dice ( void ){
    return rand()%6+1;
}

int setNumberByDifficulty( int i ){
    scanf("%d",&i);
    int szam = 0;
    switch (i)
    {
    case 1:
        szam = rand()%10+1;
        printf("Gondoltam egy egesz szamra 1 es 10 kozott. Talald ki!\n");
        break;
    case 2:
        szam = rand()%100+1;
        printf("Gondoltam egy egesz szamra 1 es 100 kozott. Talald ki!\n");
        break;
    case 3:
        szam = rand()%10000+1;
        printf("Gondoltam egy egesz szamra 1 es 1000 kozott. Talald ki!\n");
    break;
    default:
        printf("Nem baj, ha ez se jott ossze amugy se lenne veled nagy elmeny jatszani\n");
        break;
    }
    return szam;
}

int get_target(int dif){
    int szam = 0;
    switch (dif)
        {
        case 1:
            szam = rand()%10+1;
            printf("Gondoltam egy egesz szamra 1 es 10 kozott. Talald ki!\n");
            break;
        case 2:
            szam = rand()%100+1;
            printf("Gondoltam egy egesz szamra 1 es 100 kozott. Talald ki!\n");
            break;
        default:
            szam = rand()%10000+1;
            printf("Gondoltam egy egesz szamra 1 es 1000 kozott. Talald ki!\n");
            break;
        }
    return szam ;
}

static void congratulate(int tries){
    if(tries<3){
        printf("Szerintem te csalsz \n");
    }
    if(tries>3&&tries<10){
        printf("Kivalo tippelo vagy \n");
    }
    if(tries>10){
        printf("Lenne meg mit gyakorolni \n");
    }
}

void game ( void ){
    int machinenumber = 0;
    printf("Valasszon nehezsegi szintet 1-tol 3-ig: ");
    int difficulty = 0;
    scanf("%d",&difficulty);
    
    machinenumber = get_target(difficulty);
   
    
    int tries = 1;
    printf("%d. probalkozasod:",tries);
    int playernumber = -1;
    scanf("%d",&playernumber);
    while(playernumber!=machinenumber){
        ++tries;
        (playernumber>machinenumber) ? printf("Nem talalt! Az en szamom kisebb!\n") : printf("Nem talalt! Az en szamom nagyobb!\n");
        printf("%d. probalkozasod:",tries);
        scanf("%d",&playernumber);
    }
    printf("Gratulalok eltalaltad! En tenyleg %d-re/ra gondoltam.\n",machinenumber);

    printf("%d db probalkozasod volt\n",tries);

    congratulate(tries);

}

void pascalTriangle(int n){
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
            printf(" ");
        int val = 1;

        for (int k = 0; k <= i; k++) {
            printf("%d ", val);
          
            
            val = val * (i - k) / (k + 1);  
        }
        printf("\n");
    }
    
}

int main(){
    srand( time(NULL) ); //seedelni kell mert nem jo
    //op_chain();
    //decrement(); // bites bigyó, veszélyes és stackoverflow-t csinál
    leap_year();
    for (int i = 0; i < 10; i++)
    {
        printf("%02d. dobas: %d\n",i+1,dice());
    }
    game();
    

    int n = 0;
    printf("Adjon meg a egy n szamot en meg varazsolok vele pascal haromszoget: ");
    scanf("%d",&n);
    pascalTriangle(n);

    return 0;
}

void leap_year( void ){
    printf("Adjal egy evszamot: ");
    int year = 0 ;
    scanf("%d",&year);
    bool isLY = (year%4 == 0 &&( year%100 != 0 || year %400 == 0));
    (isLY) ? printf("Szokoev\n") : printf("Nem szokoev\n");
}