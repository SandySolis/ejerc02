Console.WriteLine("************************************************");
Console.Write("Ingrese el salario mensual del trabajador: ");
    int salariomensual = int.Parse(Console.ReadLine());

Console.Write("Ingrese el porcentaje del salario que la empresa deposita obligatoriamente en la cuenta SAR: ");
    int porcjeemp= int.Parse(Console.ReadLine());

Console.Write("Ingrese la cuota fija del salario que el trabajador aportará a la cuenta SAR: ");
    int aporttrabajador = int.Parse(Console.ReadLine());

    int depempresa = salariomensual * porcjeemp;
    int deptrabajador = salariomensual * aporttrabajador;
        

    int pagomensual = salariomensual - deptrabajador;

Console.WriteLine("La cantidad total que la empresa deposita en la cuenta SAR cada mes es: "+ depempresa);
Console.WriteLine("La cantidad total que el trabajador aporta a la cuenta SAR cada mes es: "+ deptrabajador);
Console.WriteLine("El pago mensual que recibe el trabajador es: "+ pagomensual);
Console.WriteLine("************************************************");
