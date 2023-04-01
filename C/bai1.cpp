#include<stdio.h> 
#include <math.h>

//void inTamGiac(int n) {
//	
//	for(int i = 1; i <= n; i++) {
//		for(int j = 1; j <= 2* i -1; j++){
//			printf("*");
//		}
//		printf("\n");	
//	}
//}
//
//int main() {
//	int n = 5;
//	inTamGiac(n);
//}


void hinhChuNhat(int n) {
//	for(int i = 1; i <= n; i++) {
//		for(int j = 1; j <= n*2; j++) {
//			if(i == 1 || i == n || j == 1 || j == n*2) {
//				printf("* ");
//			}else printf(" ");			
//		}
//		printf("\n");
//	}
	printf("Nhap vao n: ");
	scanf("%d", &n);
	
	for(int i = 1; i <= n; i++) {
		for(int j = 1; j <= n*2; j++) {
			if(i == 1 || i == n || j == 1 || j == n*2 ){
				printf("*");
			}else {
				printf(" ");
			}
			
		}
		printf("\n");
		
	}
	
}


int main() {
	hinhChuNhat(6);
}
