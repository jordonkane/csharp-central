import { Component } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request.model';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent {

  model: AddCategoryRequest;

  constructor(){
    this.model = {
      name: '',
      urlHandle: ''
    };
  }

  // Capture the two values of the forms and submit it to the API
  onFormSubmit(){
    console.log(this.model);
  }
}
