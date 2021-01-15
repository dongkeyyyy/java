
public class Main {

	public static void main(String[] args) {  // 클래스 메쏘드
		Car car = new Car();  // 객체 생성
		System.out.println("----------------------------");
		System.out.println(Car.JIJUM);
		System.out.println("----------------------------");
		car.showCarInfo();

		Car car2 = new Car("그랜저", "현대", "무지개색", "3천만원");  //	변수 생성
		car2.showCarInfo();
		
		new Car().showCarInfo();
	}

}
