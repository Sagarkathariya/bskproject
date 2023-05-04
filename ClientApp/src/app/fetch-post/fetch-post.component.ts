import { Component, Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-fetch-post',
  templateUrl: './fetch-post.component.html'
})
  /*@Injectable({
    providedIn: 'root'
  })*/
export class FetchPostComponent {
   public getJsonValues: any;


 /*  httpOptions = {
     headers: new HttpHeaders({
       'Content-Type': 'application/json'
     })
   }*/

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    let posts = 'https://jsonplaceholder.typicode.com/posts/';
    http.get(posts).subscribe((data:any) => {
      console.log(data);
      this.getJsonValues = data;
    }, (error: any) => console.error(error));
  }

 /* ngOnInit(): void {
    this.getPosts();
    throw new Error('Method not implemented.');
  }*/

  /*public getPosts() {
  let posts = 'https://jsonplaceholder.typicode.com/posts/';
    this.http.get(posts).subscribe((data) => {
      console.log(data);
      this.getJsonValues = data;
    }, error => console.error(error));  
  }*/
}
