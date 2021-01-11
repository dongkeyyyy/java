package class_0106;

public class class2 {

	public static void main(String[] args) {
		Student2 s = new Student2();
		s.setName("홍길동");
		s.setEmail("hong@naver.com");
		s.setTel("010-1234-1234");
		s.setName("김길동");
		
		System.out.println("이름 : " + s.getName());
		System.out.println("이메일 : " + s.getEmail());
		System.out.println("전화 : " + s.getTel());
		System.out.println("과정 : " + Student.category);
		
		Student2 ss = new Student2();
		ss.setName("최길동");
		ss.setEmail("choi@naver.com");
		ss.setTel("010-1234-5678");
		System.out.println("이름 : " + ss.getName());
		System.out.println("이메일 : " + ss.getEmail());
		System.out.println("전화 : " + ss.getTel());
		System.out.println("과정 : " + Student.category);
		
		// 익명 객체
		new Student2().setName("이길동");
		System.out.println(new Student2().getName());
	}

}
