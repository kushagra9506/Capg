class Product{
	private string productCode;
	private string productName;
	private double productPrice;
	private char categoryCode;
	private static int prodCounter = 100;

	public string ProductCode{
		get{ return productCode;}
		set{ productCode = value;}
	}

	public string ProductName{
		get{ return productName;}
		set{ productName = value;}
	}

	public double ProductPrice{
		get{ return productPrice;}
		set{ productPrice = value;}
	}

	public char CategoryCode{
		get{ return categoryCode;}
		set{ categoryCode = value;}
	}
	
	public int ProdCounter{
		get{ return prodCounter;}
		set{ prodCounter = value;}
	}
	
	private string generateProductCode(){
		return Convert.ToString(++prodCounter) + Convert.ToString(categoryCode);
	}

	public Product(){}
	public Product(string productName, double productPrice, char categoryCode){
		this.productName = productName;
		this.productPrice = productPrice;
		this.categoryCode = categoryCode;
		productCode = generateProductCode();
	}
	
	public Product(string productName, double productPrice){
		this.productName = productName;
		this.productPrice = productPrice;
		this.categoryCode = categoryCode;
		productCode = generateProductCode();
		CategoryCode = "E";
	}
	
	public string getProductDetails(){
		return "Code-"+categoryCode+",Name-"+productName+",Price-"+Convert.ToString(productPrice)+"Category-"+Convert.ToString(categoryCode);
	}
