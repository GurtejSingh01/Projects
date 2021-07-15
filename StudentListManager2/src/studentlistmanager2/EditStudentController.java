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
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

/**
 * FXML Controller class
 *
 * @author Gurtej singh
 */
public class EditStudentController implements Initializable {

    @FXML
    private Button btnsave;
    @FXML
    private Button btnlookup;
    @FXML
    private Button btncancel;
    @FXML
    private TextField IDfield;
    @FXML
    private TextField nameField;
    @FXML
    private TextField idField;
    @FXML
    private TextField gpaField;

    StudentList List = listManagerController.list; // A reference to the list of items

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        btnlookup.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                onlookupClicked();    // Always call a method in the outer class
            }
        });
        btnsave.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                onsaveClicked();    // Always call a method in the outer class
            }
        });
        btncancel.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                oncancelClicked();    // Always call a method in the outer class
            }
        });
    }

    private void onlookupClicked() {

        try {
            int id;
            id = Integer.parseInt(IDfield.getText());
            if (id <= 0) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Enter the Correct ID"); // Msg to display
                alert.showAndWait();
            } else if (IDfield.getText().length() != 9) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Wrong ID entered"); // Msg to display
                alert.showAndWait();
            } else {
                boolean flag = listManagerController.list.lookup(id);
                if (flag) {
                    Student s = listManagerController.list.getData();
                    nameField.setText(s.name);
                    idField.setText(Integer.toString(id));
                    gpaField.setText(Double.toString(s.gpa));
                } else {
                    Alert alert = new Alert(Alert.AlertType.ERROR, "Entered ID not found"); // Msg to display
                    alert.showAndWait();
                }
            }
        } catch (Exception e) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Enter ID"); // Msg to display
            alert.showAndWait();
        }
    }

    private void onsaveClicked() {
        String name;
        int id;
        double gpa;
        String err = "";
        try {
            name = nameField.getText();
            id = Integer.parseInt(idField.getText());
            gpa = Double.parseDouble(gpaField.getText());
            //Error handling
            if ("".equals(name) || id <= 0 || gpa <= 0) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Please enter correct details"); // Msg to display
                alert.showAndWait();
            } else if (idField.getText().length() != 9) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Please enter correct ID"); // Msg to display
                alert.showAndWait();
            } else {
                listManagerController.list.updateDetails(name, id, gpa, Integer.parseInt(IDfield.getText()));
                listManagerController.list.save();

//                    //setting fields to blank
//                    nameField.setText("");
//                    idField.setText("");
//                    gpaField.setText("");
                //loading main Scene
                // Get a reference to the stage
                Stage stage = (Stage) btncancel.getScene().getWindow();
                // Close this window
                stage.close();
            }

        } catch (Exception e) {
            //occured error
            Alert alert = new Alert(Alert.AlertType.ERROR, "Please enter correct details of a Student"); // Msg to display
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
