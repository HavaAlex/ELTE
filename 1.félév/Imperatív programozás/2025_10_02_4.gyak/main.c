#include <stdio.h>
#include <stdbool.h>

void op_chain( void ){
    int num = 3;
    (2 < num < 4) ? printf("True\n") : printf("False\n"); // Ez igy nem lesz jó mert 2<num az true azaz 1 tehát < 4
    (4 > num > 2) ? printf("True\n") : printf("False\n"); // de itt az 1 azaz az igaz nem nagyobb mint 2
}

int main(){
    op_chain();

    return 0;
}