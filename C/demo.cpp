#include<stdio.h>
#include <math.h>

void TimUoc(int a[], int n) {
	for(int i = 0; i < n; i++) {
		for(int j = 1; j <= a[i] / 2; j++) {
			if(a[i] % j == 0) {
				printf("%d ", j);
			}
		}
		printf("\n");
	}
}

int TinhTongCacUoc(int a[], int n) {
	int sum = 0;
	for(int i = 0; i < n; i++) {
		
	}
	
}

int TinhGiaiThua()

int main() {
	int a[] = {4,12,6};
	int n = 3;
	TimUoc(a, n);
	
}
