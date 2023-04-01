#include<stdio.h> 
#include <math.h>

int main() {
	int a[] = {6, 11, 34, 121};
	int n = 4, sum = 0;
	
	for(int i = 0; i < n; i++) {
		int so = a[i];
		int songc = 0;
		for(int j = so; j != 0; j /= 10) {
			songc = songc * 10 + so % 10;
		}
		if(so == songc) 
			sum += so;
	}
	
	printf("Tong la: %d", sum);
}
