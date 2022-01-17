import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-test-error',
  templateUrl: './test-error.component.html',
  styleUrls: ['./test-error.component.scss'],
})
export class TestErrorComponent {
  baseUrl: string = environment.apiUrl;
  validationErrors: any;

  constructor(private http: HttpClient) {}

  get404Error() {
    this.http
      .get(this.baseUrl + 'products/8C58183C-0EDB-4D00-A108-9F4CB1750E7C')
      .subscribe(
        (response) => console.log(response),
        (error) => console.log(error)
      );
  }

  get500Error() {
    this.http.get(this.baseUrl + 'buggy/servererror').subscribe(
      (response) => console.log(response),
      (error) => console.log(error)
    );
  }

  get400Error() {
    this.http.get(this.baseUrl + 'buggy/badrequest').subscribe(
      (response) => console.log(response),
      (error) => console.log(error)
    );
  }

  get400ValidationError() {
    this.http.get(this.baseUrl + 'products/400').subscribe(
      (response) => console.log(response),
      (error) => {
        console.log(error);
        this.validationErrors = error.errors;
      }
    );
  }
}
