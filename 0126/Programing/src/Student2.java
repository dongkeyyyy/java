import java.util.ArrayList;

public class Student2 {

	public static void main(String[] args) {
		ArrayList<Student> students = new ArrayList<Student>(); // 배열 목록? 객체 배열 (ArrayList) 생성
		students.add(new Student("이동준", 2009038033, "남"));
		students.add(new Student("이제영", 2007012034, "여"));

		for (Student item : students) {
			System.out.println(String.format("이름:%s, 학번:%d, 성별:%s", item.name, item.number, item.gender));
		}
		System.out.println();

		System.out.println();
		for (int i = 0; i < students.size(); i++) {
			if (students.get(i).name == "이동준") {
				students.get(i).setNumber(2019038033);
			}
		}
		for (Student item : students) {
			System.out.println(String.format("이름:%s, 학번:%d, 성별:%s", item.name, item.number, item.gender));
		}

	}

}
