#include<stdio.h> 
#include <math.h>

int main() {	
//	int n;
//	printf("Nhap so phan tu cua mang: ");
//	scanf("%d", &n);
//	
//	int a[n];
//	for(int i = 0; i < n; i++) {
//		printf("a[%d] = ", i);
//		scanf("%d", &a[i]);
//	}
	int a[] = {121, 11, 34, 67};
	int n = 4, sum = 0;
	
	for(int i = 0; i < n; i++) {
		int so = a[0];
		int songc = 0;
		for(int j = so; j != 0; i /= 10) {
			songc = songc * 10 + so % 10;
		}
		if(so == songc) {
			sum += so;
		}
	}
	
	printf("Tong la: %d", sum);
}



