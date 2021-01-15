
public class Car {
	public static final String JIJUM = "동대구 영업소"; // 상수 클래스변수 (상수클래스변수는 대문자로) static가 붙으면 클래스 변수 붙지 않으면 인스턴스 변수
	// 매개 인스턴스 변수 선언
	private String model;
	private String company;
	private String color;
	private String price;

	public Car() { // 기본 생성자 생성 생성자는 public 앞에 void가 붙지 않는 특수한 경우 오버로딩
		model = "k7";
		company = "기아";
		color = "블랙";
		price = "사천만원";
	}

	public Car(String model, String company, String color, String price) { // 매개 변수를 사용하는 생성자 (매개 변수를 사용할 항목들을 컨스터럭터 유징)
																			// 필드에서 항목선택 후 생성)
		super(); // 자바 최상위 오브젝트를 칭한다. 둬도 되고 없애도 되는.
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}

	// 설정, 가져오는 인스턴스 메쏘드 추가
	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getCompany() {
		return company;
	}

	public void setCompany(String company) {
		this.company = company;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	public void showCarInfo() { // 객체의 안에 만들어진 인스턴스 (메쏘드 모든 변수 정보를 출력하는)
		System.out.println("-----------------------------");
		System.out.println("영업소 : " + Car.JIJUM);	
		System.out.println("-----------------------------");
		System.out.println("제조사 : " + company);
		System.out.println("모델 : " + model);
		System.out.println("가격 : " + price);
		System.out.println("색상 : " + color);
		System.out.println("-----------------------------");
	}

}
