#include <stdio.h>

 

int main(){
    int n = 0;

    int m = 0;

    printf("Adjon meg egy magasságot: ");

    scanf("%d",&n);

    printf("Adjon meg egy szélességet: ");

    scanf("%d",&m);

    for(int i = 0;  i<n; i++)
    {
            for(int j =0 ; j<m; j++)
            {
                    printf("a");
            }
            printf("\n");
    }
    return 0;
}