#include <stdio.h>
#include <stdlib.h>


typedef struct  {


int Tope;
int Max;
	
}PilaLimites;


void print_Array(int* Array){
int i;
	for(i = 0; i < 5;i++){
		printf("[%d] ", Array[i]);
	}
		
}

void llenar_Producto(int* Producto){
	int i;
	for(i = 0; i < 5; i++){
		Producto[i] = 1;
	}
	
}

void vaciar_Producto(int* Producto){
	int i;
	for(i = 0; i < 5; i++){
		Producto[i] = 0;
	}
	
}

void todo_Lleno(PilaLimites *ArrayLimits   ){
	int i;
	
	for(i = 0; i < 12; i++){
		ArrayLimits[i].Max = 4;
		ArrayLimits[i].Tope = 4;
	}
}

void todo_Vacio(PilaLimites *ArrayLimits  ){
	int i;
	
	for(i = 0; i < 12; i++){
		
			ArrayLimits[i].Max = 4;
			ArrayLimits[i].Tope = -1;
	}
	
}

int main(int argc, char *argv[]) 
{
	
		int X;
		int Y;
		int Resp;
		int Opc;
		
		int Producto_0[5] = {0};
		int Producto_1[5] = {0};
		int Producto_2[5] = {0};
		int Producto_3[5] = {0};
		int Producto_4[5] = {0};
		int Producto_5[5] = {0};
		int Producto_6[5] = {0};
		int Producto_7[5] = {0};
		int Producto_8[5] = {0};
		int Producto_9[5] = {0};
		int Producto_10[5] = {0};
		int Producto_11[5] = {0};	
		

		PilaLimites ArrayLimits [12];
		
		int i; 
		int j;
	
	
		do{
		printf("Desea Comenzar con la Maquina llena? SI/NO (1/0): ");	
		scanf("%d",&Resp);
		}while(Resp != 1 && Resp != 0);
		
		if(Resp == 1){
			
		todo_Lleno(ArrayLimits);		
		
		llenar_Producto(Producto_0);
		llenar_Producto(Producto_1);
		llenar_Producto(Producto_2);
		llenar_Producto(Producto_3);
		llenar_Producto(Producto_4);
		llenar_Producto(Producto_5);
		llenar_Producto(Producto_6);
		llenar_Producto(Producto_7);
		llenar_Producto(Producto_8);
		llenar_Producto(Producto_9);
		llenar_Producto(Producto_10);
		llenar_Producto(Producto_11);
		
		}else{
		todo_Vacio(ArrayLimits);
		
		} 
		
		
		
		system("pause");
		system("cls");
	do{	
			printf("\nMenu Principal:\n");
			printf("********************************************\n");
			printf("**   Meter Elemento  	 .......... [1]   **\n"); 
			printf("**   Comprar Elemento    .......... [2]   **\n");
			printf("**   Llenar Todo         .......... [3]   **\n");
			printf("**   Vaciar Todo         .......... [4]   **\n");
			printf("**   Salir               .......... [5]   **\n");
			printf("********************************************\n");
			printf("\nOpcion: ");
			scanf("%d",&Opc);
			switch(Opc){
				case 1 :{
					do{
						
					system("cls");	
					printf("Ingrese posiciones (x,y) MAX(2,3):  \n");
					scanf("%d",&X);
					scanf("%d",&Y);
					if(X > 2 || Y > 3){
						system("cls");
						printf("El producto no existe\n ");
						system("pause");
					}
					
					}while(X > 2 || Y > 3);
					
					
					
					if(X== 0 && Y == 0){
						if(ArrayLimits[0].Tope < ArrayLimits[0].Max){
							ArrayLimits[0].Tope++;
							Producto_0[ArrayLimits[0].Tope] = 1;
							print_Array(Producto_0);
													
						}else{
							printf("Producto lleno\n ");
						}
					}
					
					if(X== 0 && Y == 1){
						if(ArrayLimits[1].Tope < ArrayLimits[1].Max){
							ArrayLimits[1].Tope++;
							Producto_1[ArrayLimits[1].Tope] = 1;
							print_Array(Producto_1);		
						}else{
							printf("Producto lleno\n ");
						}
					}
					
					if(X== 0 && Y == 2){
						if(ArrayLimits[2].Tope < ArrayLimits[2].Max){
							ArrayLimits[2].Tope++;		
							Producto_2[ArrayLimits[2].Tope] = 1;
							print_Array(Producto_2);
						}else{
							printf("Producto lleno\n ");
						}
					}
					
					if(X== 0 && Y == 3){
						
						if(ArrayLimits[3].Tope < ArrayLimits[3].Max){
							ArrayLimits[3].Tope++;	
							Producto_3[ArrayLimits[3].Tope] = 1;
							print_Array(Producto_3);
								
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 1 && Y == 0){
						
						if(ArrayLimits[4].Tope < ArrayLimits[4].Max){
							ArrayLimits[4].Tope++;		
							Producto_4[ArrayLimits[4].Tope] = 1;
							print_Array(Producto_4);
							
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 1 && Y == 1){
						
						if(ArrayLimits[5].Tope < ArrayLimits[5].Max){
							ArrayLimits[5].Tope++;	
							Producto_5[ArrayLimits[5].Tope] = 1;	
							print_Array(Producto_5);
							
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 1 && Y == 2){
						
						if(ArrayLimits[6].Tope < ArrayLimits[6].Max){
							ArrayLimits[6].Tope++;
							Producto_6[ArrayLimits[6].Tope] = 1;		
							print_Array(Producto_6);
							
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 1 && Y == 3){
						
						if(ArrayLimits[7].Tope < ArrayLimits[7].Max){
							ArrayLimits[7].Tope++;		
							Producto_7[ArrayLimits[7].Tope] = 1;
							print_Array(Producto_7);
							
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 2 && Y == 0){
						
						if(ArrayLimits[8].Tope < ArrayLimits[8].Max){
							ArrayLimits[8].Tope++;
							Producto_8[ArrayLimits[8].Tope] = 1;		
							print_Array(Producto_8);
						
						}else{
							printf("Producto lleno\n ");
						}
					}
					
					if(X== 2 && Y == 1){
						
						if(ArrayLimits[9].Tope < ArrayLimits[9].Max){
							ArrayLimits[9].Tope++;
							Producto_9[ArrayLimits[9].Tope] = 1;		
							print_Array(Producto_9);
						
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 2 && Y == 2){
						
						if(ArrayLimits[10].Tope < ArrayLimits[10].Max){
							ArrayLimits[10].Tope++;		
							Producto_10[ArrayLimits[10].Tope] = 1;		
							print_Array(Producto_10);
						
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 2 && Y == 3){
						
						if(ArrayLimits[11].Tope < ArrayLimits[11].Max){
							ArrayLimits[11].Tope++;		
							Producto_11[ArrayLimits[11].Tope] = 1;		
							print_Array(Producto_11);
						
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					break;
				}
				case 2 :{
					system("cls");
					do{
						
					printf("Ingrese posiciones (x,y) MAX(2,3):  \n");
					scanf("%d",&X);
					scanf("%d",&Y);
					if(X > 2 || Y > 3){
						
						system("cls");
						printf("El producto no existe\n ");
						system("pause");
					}
					}while(X > 2 || Y > 3);
					
					
					if(X== 0 && Y == 0){
						
						if(ArrayLimits[0].Tope >= 0){
							Producto_0[ArrayLimits[0].Tope] = 0;
							ArrayLimits[0].Tope--;
							print_Array(Producto_0);	
									
						}else{
							printf("Producto Vacio \n ");
						}
					}
					
					if(X== 0 && Y == 1){
						if(ArrayLimits[1].Tope >= 0){
							Producto_1[ArrayLimits[1].Tope] = 0;		
							ArrayLimits[1].Tope--;
							print_Array(Producto_1);
							
						}else{
							printf("Producto Vacio ");
						}
					}
					
					if(X== 0 && Y == 2){
						if(ArrayLimits[2].Tope >= 0){
							Producto_2[ArrayLimits[2].Tope] = 0;
							ArrayLimits[2].Tope--;		
							print_Array(Producto_2);
							
						}else{
							printf("Producto Vacio\n ");
						}
					}
					
					if(X== 0 && Y == 3){
						
						if(ArrayLimits[3].Tope >= 0){
							Producto_3[ArrayLimits[3].Tope] = 0;	
							ArrayLimits[3].Tope--;	
							print_Array(Producto_3);
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 1 && Y == 0){
						
						if(ArrayLimits[4].Tope >= 0){
							Producto_4[ArrayLimits[4].Tope] = 0;
							ArrayLimits[4].Tope--;		
							print_Array(Producto_4);
							
						}else{
							printf("Producto Vacio \n ");
						}	
					}
					
					if(X== 1 && Y == 1){
						
						if(ArrayLimits[5].Tope >= 0){
							Producto_5[ArrayLimits[5].Tope] = 0;
							ArrayLimits[5].Tope--;	
							print_Array(Producto_5);
						}else{
							printf("Producto Vacio\n ");
						}	
					}
					
					if(X== 1 && Y == 2){
						
						if(ArrayLimits[6].Tope >= 0){
							Producto_6[ArrayLimits[6].Tope] = 0;		
							ArrayLimits[6].Tope--;
							print_Array(Producto_6);
						}else{
							printf("Producto Vacio\n ");
						}	
					}
					
					if(X== 1 && Y == 3){
						
						if(ArrayLimits[7].Tope >= 0){
							Producto_7[ArrayLimits[7].Tope] = 0;
							ArrayLimits[7].Tope--;		
							print_Array(Producto_7);
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 2 && Y == 0){
						
						if(ArrayLimits[8].Tope >= 0){
							Producto_8[ArrayLimits[8].Tope] = 0;
							ArrayLimits[8].Tope--;
							print_Array(Producto_8);		
						}else{
							printf("Producto lleno\n ");
						}
					}
					
					if(X== 2 && Y == 1){
						
						if(ArrayLimits[9].Tope >= 0){
							Producto_9[ArrayLimits[9].Tope] = 0;		
							ArrayLimits[9].Tope--;
							print_Array(Producto_9);
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 2 && Y == 2){
						
						if(ArrayLimits[10].Tope >= 0){
							Producto_10[ArrayLimits[10].Tope] = 0;		
							ArrayLimits[10].Tope--;		
							print_Array(Producto_10);
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
					if(X== 2 && Y == 3){
						
						if(ArrayLimits[11].Tope >= 0){
							Producto_11[ArrayLimits[11].Tope] = 0;		
							ArrayLimits[11].Tope--;		
							print_Array(Producto_11);
						}else{
							printf("Producto lleno\n ");
						}	
					}
					
				break;
				}
				case 3 :{
					system("cls");
					printf("Todo lleno\n");
					
					todo_Lleno(ArrayLimits);		
		
					llenar_Producto(Producto_0);
					llenar_Producto(Producto_1);
					llenar_Producto(Producto_2);
					llenar_Producto(Producto_3);
					llenar_Producto(Producto_4);
					llenar_Producto(Producto_5);
					llenar_Producto(Producto_6);
					llenar_Producto(Producto_7);
					llenar_Producto(Producto_8);
					llenar_Producto(Producto_9);
					llenar_Producto(Producto_10);	
					llenar_Producto(Producto_11);
					system("pause");
					break;
				}
				case 4 :{
					system("cls");
						printf("Todo vacio \n");
						todo_Vacio(ArrayLimits);
						vaciar_Producto(Producto_0);
						vaciar_Producto(Producto_1);
						vaciar_Producto(Producto_2);
						vaciar_Producto(Producto_3);
						vaciar_Producto(Producto_4);
						vaciar_Producto(Producto_5);
						vaciar_Producto(Producto_6);
						vaciar_Producto(Producto_7);
						vaciar_Producto(Producto_8);
						vaciar_Producto(Producto_9);
						vaciar_Producto(Producto_10);
						vaciar_Producto(Producto_11);
						system("pause");	
						
					break;
				}
				case 5:{
					exit(0);
					break;
				}
				default:{
					
					system("cls");
					printf("\nINGRESE UNA OPCION CORRECTA !!!\n");
					system("pause");
					
					break;
				}
			}
		
		}while(Opc != 5);
		
		
	
	
	
	return 0;
}







