
public class Student {
	String name;
    int number;
    String gender;
    
    public Student(String n, int num, String g) {
        name=n;
        number=num;
        gender=g;
    }
    
    public void setNumber(int i){
        number=i;
    }
    
    public void setName(String n) {
        name=n;
        
    }
    
    public void setGender(String n) {
        gender=n;
    }

	public String getName() {
		return name;
	}

	public int getNumber() {
		return number;
	}

	public String getGender() {
		return gender;
	}
}
