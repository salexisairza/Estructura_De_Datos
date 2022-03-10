using (resource)
{
     {
  namespace Name
  {
     
    int num;
    int i=0;

    while(i<1){
        Console.Write("Intrudzca un numero par entre 100 y 200: ");
        Console.Read("%d",&num);
        if(num>=100 && num<=200 && num%2==0){i++;}
    }

    for(i=num;i<=200;i=i+2){
        Console.Read("%d\t",i);
    }

    return 0;
} 
  }  
    
}

