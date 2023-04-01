#include<stdio.h> 
#include <math.h>

int NhapMang(int a[], int n) {
	for(int i = 0; i < n; i++) {
		printf("a[%d]= ", i);
		scanf("%d", &a[i]);
	}
}

int UCLN(int a, int b) {
	int x = a, y = b;
	while(x != y)
		x > y ? x -= y : y -= x;
	return y;
}

int UCLNofArr(int a[], int n) {
	int ucln = a[0];
	for(int i = 1; i < n; i++){
		ucln = UCLN(ucln, a[i]);
	}		
	return ucln;
}

int main() {
	int n;
	printf("Nhap vao so phan tu cua mang: ");
	scanf("%d", &n);
	int a[n];
	NhapMang(a, n);
	printf("UCLN cua tat ca cac phan tu trong mang la: %d", UCLNofArr(a, n));
}
