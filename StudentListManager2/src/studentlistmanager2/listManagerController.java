/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package studentlistmanager2;

import java.io.IOException;
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
import javafx.stage.Modality;
import javafx.stage.Stage;

/**
 *
 * @author Gurtej singh
 */
public class listManagerController implements Initializable {

    @FXML
    public TextArea textArea;
    @FXML
    private Button btnadd;
    @FXML
    private Button btnedit;
    @FXML
    private Button btndelete;
    @FXML
    protected TextField listCounter;
    @FXML
    private TextField IdField;
    static StudentList list = new StudentList();
    AddStudentController Control;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        btnadd.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                onaddClicked();    // Always call a method in the outer class
            }
        });
        btndelete.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                ondeleteClicked();    // Always call a method in the outer class
            }
        });
        btnedit.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent e) {
                oneditClicked();    // Always call a method in the outer class
            }
        });
        btndelete.setDisable(false);
        btnedit.setDisable(false);
        IdField.setDisable(false);
        listCounter.setText("List of all students (" + list.getSize() + ")"); //updating student count

        textArea.setText(list.load()); //updating textArea
    }

    private void onaddClicked() {
        try {
            Parent root = FXMLLoader.load(getClass().getResource("AddStudent.fxml"));
            Scene scene = new Scene(root);

            Stage secondStage = new Stage();
            secondStage.setScene(scene);
            secondStage.initModality(Modality.APPLICATION_MODAL);  // Use this to make the 2nd window modal (must close 2nd window to return to main window)
            secondStage.showAndWait();

            textArea.setText(list.load());//updating textArea
            listCounter.setText("List of all students (" + list.getSize() + ")");//updating student count
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    private void ondeleteClicked() {
        try {
            String id = IdField.getText();
            int uid = Integer.parseInt(id);
            if (id.length() != 9 || uid <= 0) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Plaease Fill The proper ID"); // Msg to display
                alert.showAndWait();
            } else if ("".equals(id)) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Plaease Fill The Student ID"); // Msg to display
                alert.showAndWait();
            } else {
                //flag to check that id is present in the list or not
                boolean flag = list.delete(uid);
                if (!flag) {
                    Alert alert = new Alert(Alert.AlertType.ERROR, "Entered ID is not present"); // Msg to display
                    alert.showAndWait();

                } else {
                    list.save();
                    textArea.setText(list.load()); //updating textArea
                    listCounter.setText("List of all students (" + list.getSize() + ")"); //updating student count
                    IdField.setText("");

                }
            }

        } catch (Exception e) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Please enter correct ID"); // Msg to display
            alert.showAndWait();
        }
    }

    private void oneditClicked() {
        try {
            Parent root = FXMLLoader.load(getClass().getResource("editStudent.fxml"));
            Scene scene = new Scene(root);

            Stage secondStage = new Stage();
            secondStage.setScene(scene);
            secondStage.initModality(Modality.APPLICATION_MODAL);  // Use this to make the 2nd window modal (must close 2nd window to return to main window)
            secondStage.showAndWait();

            textArea.setText(list.load());//updating textArea
            listCounter.setText("List of all students (" + list.getSize() + ")");//updating student count
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
