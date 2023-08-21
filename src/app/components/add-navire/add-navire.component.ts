import { Component, OnInit } from '@angular/core';
import { Navire } from 'src/app/models/navire.model';
import { NavireService } from 'src/app/services/navire.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-navire',
  templateUrl: './add-navire.component.html',
  styleUrls: ['./add-navire.component.css']
})

export class AddNavireComponent implements OnInit {

  navire: Navire = {
    numero: '',
    nom: '',
    annee: '',
    longueur: '',
    largeur:'',
    tonnageBrut:'',
    tonnageNet:'',
    note:''

  };
  submitted = false;

  constructor(private navireService: NavireService) { }

  ngOnInit(): void {
  }

  saveNavire(): void {
    const data = {
      numero: this.navire.numero,
      nom: this.navire.nom,
      annee: this.navire.annee,
      longueur: this.navire.longueur,
      largeur: this.navire.largeur,
      tonnageBrut: this.navire.tonnageBrut,
      tonnageNet: this.navire.tonnageNet,
      note: this.navire.note
    };

    this.navireService.create(data)
      .subscribe({
        next: (res) => {
          console.log(res);
          this.submitted = true;
        },
        error: (e) => console.error(e)
      });
  }

  newNavire(): void {
    this.submitted = false;
    this.navire = {
      numero: '',
      nom: '',
      annee: '',
      longueur: '',
      largeur: '',
      tonnageBrut: '',
      tonnageNet: '',
      note: ''
    };
  }


}
