import { Component, Input } from '@angular/core';


@Component({
  selector: 'app-viewport',
  templateUrl: './viewport.component.html',
  styleUrl: './viewport.component.css'
})
export class ViewportComponent {

  @Input() path: string = "";

}
