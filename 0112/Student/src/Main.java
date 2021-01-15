import java.util.Random;

public class Main {

	public static void main(String[] args) {
		Student info[] = new Student[10];
		
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		int age[] = { 20, 25, 30, 35, 40 };
		char gender[] = { '남', '여' };
		String address[] = { "대구 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		
		Random r = new Random() ; 
		for(int i = 0; i<10; i++) {
			info[i] = new Student(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
			
		}
		
		for(int i = 0; i<10; i++) {
			info[i].showStudentInfo();
		}
		
		info[9].setName("전우치");
		info[9].setAge(24);
		info[9].setGender('남');
		info[9].setAddress("조선 한양인근 두메산골");
		
		info[9].showStudentInfo();
		
				
	}
	
	

}
