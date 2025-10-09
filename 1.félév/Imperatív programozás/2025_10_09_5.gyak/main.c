#include <stdio.h>
#include <ctype.h>
#define N 5
#define BUFFER 100
#define STR(x) HELP(x) //odaadja a 100 a helpnek, ha nem tenné az lenne a string hogy "BUFFER"
#define HELP(x) #x


void array_init( void ){

    int arr1[5] = {0,0,0,0,0};
    int arr2[N] = {0};//a többi 0 lesz
    int arr3[N] = {1};// a kimaradtakat 0val tolti ki
    int arr4[N] = {2,3};
    int arr5[N]; //memoriaszemet mert a c az ilyen ezt kell szeretni
    for (int i = 0; i < N; i++)
    {
        printf("%d, \t%d, \t%d, \t%d, \t%d, \n",arr1[i],arr2[i],arr3[i],arr4[i],arr5[i]);
    }
    printf("\n");

    int arr2D[2][3] = { {297,451,532},{265,421,888}};
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%d ",arr2D[i][j]);
        }
        printf("\n");
    }

    int arr[] = {1,2,3,4,5,6,7,8,9,0};
    size_t n =sizeof( arr ) / sizeof( arr[0] );//összes elem lefoglalte helye/ egy elem lefoglalt helye (mind a ketto byte-ban)
    printf("tomb merete: %d\n",n);    
}
void char_size( void ){

    printf("Kerek egy szoveget\n");
    char input[BUFFER+1];
    //scanf("%10[^\n]s",input); //nem kell & mert a tömbe eleve mutat egy helyre
    
    scanf("%"STR(BUFFER)"[^\n]s",input);//makróval mert az úgy jobb ha nem kell átirni
    
    printf("A megadott input: %s\n",input);
    //regex 10hossz és ^ melyik karakterek nem kellenek(enter mert azzal zárja le a felhasználó a mondatot)
    size_t n =sizeof( input ) / sizeof( input[0] );
    printf("A tomb kapacitasa: %lld ",n); // ez nem teljesen a length
    size_t size = 0;
    while( input[size] != '\0'){ //ez agyja meg hogy a bufferbül hány mezp van felhasznalva
        size++;
    }
    printf("A tarolt karakterej szama: %lld\n",size);
}

int getLength( int size, char t[]){
    while( t[size] != '\0'){ 
        size++;
    }
    return size;
}

int getLengthInt( int size, int t[]){
    while( t[size] != '\0'){ 
        size++;
    }
    return size;
}

void allToLower(char t[],int size){
    for (int i = 0; i < size; i++)
    {
        t[i] = tolower(t[i]);
    }
    
}
void feladat7( void ){
    char input1[BUFFER+1];
    char input2[BUFFER+1];
    printf("Adjon meg egy szot: ");
    scanf("%"STR(BUFFER)"[^\n]s",input1);
    getchar(); // benn maradt enter elmegy
    printf("Meg meg egyet: ");
    scanf("%"STR(BUFFER)"[^\n]s",input2);
    printf("\n");
    size_t size1 = 0;
    size_t size2 = 0;
    size1 = getLength(size1, input1);
    size2 = getLength(size2, input2);
    printf("%d es %d a ket hossz\n",size1,size2);
    allToLower(input1, size1);
    allToLower(input2,size2);
    printf("%s es %s lettek\n",input1,input2);


    int i = 0;
    if(size1>size2){
        while(i<size1){
            printf("%d. alkalom, %c es %c a jeloltek\n",i,input1[i],input2[i]);
            if(input1[i]<input2[i]){
                printf("Az elso elorebb van az abc-be\n");
                break;
            }
            if(input1[i]>input2[i]){
                printf("A masodik az abcbe elorebb van!\n");
                break;
            }
            else{
                i++;
            }
        }
        if(i==size1){
            printf("Konkrétan ugyanaz a 2\n");
        }
    }
    else{
        while(i<size2){
            printf("%d. alkalom, %c es %c a jeloltek\n",i,input1[i],input2[i]);
            if(input1[i]<input2[i]){
                printf("Az elso elorebb van az abc-be\n");
                break;
            }
            if(input1[i]>input2[i]){
                printf("A masodik az abcbe elorebb van!\n");
                break;
            }
            else{
                i++;
            }
        }
        if(i==size2){
            printf("Konkretan ugyanaz a 2\n");
        }
    }
    
}
int main(){
     //array_init();
    //char_size();

    //1
    
    int arr1[8] = {0};
    for (int i = 0; i < 8; i++)
    {
        printf("%d ",arr1[i]);
    }
    printf("\n");

    //2

    int arr2[5] = {5,3,2,6,7};
    int sum = 0;
    int size2 = 0;
    size2 = getLengthInt(size2, arr2);
    for (int i = 0; i < size2; i++)
    {
        sum = sum+arr2[i];
    }
    printf("Osszeg: %d\n",sum);
    
    //3

    int arr3[8] = {2,420,69,88,1848,4,12,9};
    int max = arr3[0];
    int size3 = 0;
    size3 = getLengthInt(size3,arr3);

    for (int i = 1; i < size3; i++)
    {
        if(max<arr3[i]){
            max = arr3[i];
        }
    }
    printf("A legnagyobb az pont: %d\n",max);
    
    //4 félész cucc 
    /*int arr4[10] = {2,420,69,88,1848,4,12,9,1,11};
    int size4 = 0;
    size4 = getLengthInt(size4,arr4);
    int min = arr4[0];
    int almostmin = arr4[1];
    for (int i = 1; i < size4; i++)
    {
        if(min>arr4[i]){
            min = arr4[i];
        }
    }
    for (int i = 0; i < size4; i++)
    {
        print("%d alkalom : arr4[i] = %d és almosmin = %d", i,arr4[i],almostmin );
        if(arr4[i]>min && arr4[i]<min){
            
            almostmin = arr4[i];
        }
    }
    printf("A legkosebb: %d\n",min);
    printf("A masodik legkisseb: %d \n",almostmin);*/
    

    feladat7();

    int c;
    while ((c = getchar()) != EOF){}
    {
        
    }
    while( scanf("%c",&c)!= EOF){

    }
    
    return 0;
}