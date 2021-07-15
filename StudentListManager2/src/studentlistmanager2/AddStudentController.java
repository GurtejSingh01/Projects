/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package studentlistmanager2;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Modality;
import javafx.stage.Stage;

/**
 * FXML Controller class
 *
 * @author Gurtej singh
 */
public class AddStudentController implements Initializable {
//
    // StudentList list= new StudentList(); 

    StudentList List = listManagerController.list; // A reference to the list of items

    Student student;
    @FXML
    private Button btnadd;
    @FXML
    private Button btncancel;
    @FXML
    protected TextField nameField;
    @FXML
    protected TextField idField;
    @FXML
    protected TextField gpaField;
    @FXML
    public TextArea textArea;

    @FXML
    protected TextField listCounter;

    // A reference to the list of items
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        btnadd.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                onaddClicked();    // Always call a method in the outer class
            }
        });
        btncancel.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                oncancelClicked();    // Always call a method in the outer class
            }
        });
    }

    private void onaddClicked() {

        try {
            String name = nameField.getText();
            int id = Integer.parseInt(idField.getText());
            double gpa = Double.parseDouble(gpaField.getText());
            //Error handling
            if (nameField.getText().isEmpty()) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Plaease Fill the Name"); // Msg to display
                alert.showAndWait();
            } else if (idField.getText().length() != 9) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Plaease Fill The proper Student ID"); // Msg to display
                alert.showAndWait();
            } else {
                Student Student = new Student(name, id, gpa);

                listManagerController.list.add(Student);
                listManagerController.list.save();
                Stage stage = (Stage) btnadd.getScene().getWindow();
                stage.close();

            }

        } catch (Exception e) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Plaease Fill The proper Information"); // Msg to display
            alert.showAndWait();

        }

    }

    private void oncancelClicked() {
        // Get a reference to the stage
        Stage stage = (Stage) btncancel.getScene().getWindow();
        // Close this window
        stage.close();
    }

}
