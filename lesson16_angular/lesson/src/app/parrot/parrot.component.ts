import { Component } from '@angular/core';
import { ParrotNamesService } from '../services/parrot-names.service';

@Component({
  providers: [ParrotNamesService],
  selector: 'app-parrot',
  templateUrl: './parrot.component.html',
  styleUrls: ['./parrot.component.css']
})
export class ParrotComponent {
  constructor(private parrotNamesService: ParrotNamesService) {}

  name: string = "";
  wingSpan: string = "";

  ngOnInit(): void {
    this.name = this.parrotNamesService.getNames()[0];
    this.wingSpan = "" + Math.floor(Math.random()*100);
    
    console.log(this.name);
  }
}
