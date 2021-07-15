package studentlistmanager2;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class StudentList {

    ArrayList<Student> list;
    Student searchedStudent;

    public StudentList() {
        list = new ArrayList<>();
    }

    String load() {
        list.clear();
        String data = "";

        try {
            File fp = new File("student.txt");
            try (Scanner sc = new Scanner(fp)) {
                while (sc.hasNextLine()) {
                    String d = sc.nextLine();
                    String[] temp = d.split(",");
                    Student s = new Student(temp[0], Integer.parseInt(temp[1]), Double.parseDouble(temp[2]));
                    list.add(s);
                    data += temp[0] + "\t\t\t" + temp[1] + "\t\t\t" + temp[2] + "\n";
                }
            }
        } catch (FileNotFoundException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
        return data;
    }

    void save() {
        try {
            String data = "";
            FileWriter fw = new FileWriter("student.txt");
            for (Student s : list) {
                data += s.getName() + "," + s.getId() + "," + s.getGpa() + "\n";
            }
            fw.write(data);
            fw.close();

            System.out.println("Successfully wrote to the file.");
        } catch (IOException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
    }

    int getSize() {
        return list.size();
    }

    void add(Student s) {
        list.add(s);
        System.out.println("Data Added!");
    }

    boolean delete(int id) {
        for (int i = 0; i < list.size(); i++) {
            Student s = list.get(i);
            if (s.id == id) {
                list.remove(i);
                return true;
            }
        }
        return false;
    }

    boolean lookup(int id) {
        for (Student s : list) {
            if (s.id == id) {
                searchedStudent = s;
                return true;
            }
        }
        return false;
    }

    Student getData() {
        return searchedStudent;
    }

    void updateDetails(String name, int id, double gpa, int prevID) {
        for (Student s : list) {
            if (s.id == prevID) {
                s.name = name;
                s.id = id;
                s.gpa = gpa;
            }
        }
    }

}
