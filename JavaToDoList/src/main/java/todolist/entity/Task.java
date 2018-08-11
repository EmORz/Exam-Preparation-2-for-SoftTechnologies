package todolist.entity;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "tasks")
public class Task {
	//TODO:Implement me...
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @Column
    @NotNull
    private String title;

    @Column
    @NotNull
    private String comments;


    public Task() {
    }

    public Task(@NotNull String title, @NotNull String comments) {
        this.title = title;
        this.comments = comments;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @NotNull
    public String getTitle() {
        return title;
    }

    public void setTitle(@NotNull String title) {
        this.title = title;
    }

    @NotNull
    public String getComments() {
        return comments;
    }

    public void setComments(@NotNull String comments) {
        this.comments = comments;
    }
}
