

double resultadosPosibles(double x, double y, double z, double *x1, double *x2, double *discriminante);
int main ()
{
	double a=0,b=0,c=0,x1=0,x2=0,discriminante=0;
	
	printf("Por favor genere el coeficiente a\n");
	scanf("%lf",&a);
	printf("Por favor genere el coeficiente b\n");
	scanf("%lf",&b);
	printf("Por favor genere el coeficiente c\n");
	scanf("%lf",&c);
	
	resultadosPosibles(a,b,c,&x1,&x2,&discriminante);
	
	if(discriminante < 0)
	{
		printf("Este programa no maneja numeros complejos, el discriminante es menor a 0\n discriminante = %lf",discriminante);
		
	}else 
	
	if(a != 0)
	{
		printf("Los posibles valores de la ecuacion son:\n");
		
		printf("x1 = %.2lf\n",x1);
		printf("x2 = %.2lf\n",x2);
		
	}else 
	
	printf("Usted genero a igual a 0, matematicamente es imposible trabajar divisiones entre cero, incluso el campo de los numeros complejos no contiene este tipo de operacion, busque las propiedades de los limites\n");
	return 0;
}
double resultadosPosibles(double x, double y, double z, double *x1, double *x2, double *discriminante)
{
	*x1 = (-y + sqrt(y*y-4*x*z))/(2*x);
	*x2 = (-y - sqrt(y*y-4*x*z))/(2*x);
	
	*discriminante = pow(y,2)-4*x*z;
			
}