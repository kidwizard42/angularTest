import { Component, Inject, OnInit} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { inject } from '@angular/core/testing';


@Component({
  selector: 'app-note-taking',
  templateUrl: './note.component.html',
  styleUrls:['./note.component.css']
})
export class NoteComponent {

  public test: string[] = [];

  ngOnInit(): void {
    //console.log('lets gooooo')
    //console.log(this.test)
    //console.log(Object)
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http.get<Object>(baseUrl + 'notesbro').subscribe(result => {
      //this.test = result;
      console.log(baseUrl);
      console.log(result);
      for (const [key, value] of Object.entries(result)) {
        console.log(`${key}: ${value}`);
      }
    }, error => console.error(error));

  }

  //How will I catch the exceptions and send that to the user. global exception handling???
  //the 500 error is bad. 
  testEndpoint() {
    this.http.get<Object>('https://localhost:44452/notesbro/' + 1).subscribe(result => {

      console.log(result);
      
    }, error => console.error(error));
  }

  //NEXT STEPS ADD EXCEPTION CATCHING ABOVE IN BACKEND
  // ALLOW YOU TO HAVE UP TO THREE NOTES? OR INFINITE NOTES??
  //SDFSF

  enterNote( note:string) {
    console.log(note);
    //console.log(this.test)

    this.http.put<Object>('https://localhost:44452/notesbro', {2: note}).subscribe(result => {
      //this.test = result;
      console.log(result);
    }, error => console.error(error));

  }


}