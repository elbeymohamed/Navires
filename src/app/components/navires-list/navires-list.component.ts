import { Component, OnInit } from '@angular/core';
import { Navire } from 'src/app/models/navire.model';
import { NavireService } from 'src/app/services/navire.service';


@Component({
  selector: 'app-navires-list',
  templateUrl: './navires-list.component.html',
  styleUrls: ['./navires-list.component.css']
})

export class NaviresListComponent implements OnInit {

  navires?: Navire[];
  currentNavire: Navire = {
    numero: undefined,
    nom: undefined,
    annee: undefined,
    longueur: undefined,
    largeur: undefined,
    tonnageBrut: undefined,
    tonnageNet: undefined,
    note: undefined
  };
  currentIndex = -1;
  nom = '';

  constructor(private navireService: NavireService) { }

  ngOnInit(): void {
    this.retrieveNavires();
  }

  retrieveNavires(): void {
    this.navireService.getAll()
      .subscribe({
        next: (data) => {
          this.navires = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }

  refreshList(): void {
    this.retrieveNavires();
    this.currentNavire = {
    numero: undefined,
    nom: undefined,
    annee: undefined,
    longueur: undefined,
    largeur: undefined,
    tonnageBrut: undefined,
    tonnageNet: undefined,
    note: undefined
    };
    this.currentIndex = -1;
  }

  setActiveNavire(navire: Navire, index: number): void {
    this.currentNavire = navire;
    this.currentIndex = index;
  }


  searchName(): void {
    this.currentNavire = {
    numero: undefined,
    nom: undefined,
    annee: undefined,
    longueur: undefined,
    largeur: undefined,
    tonnageBrut: undefined,
    tonnageNet: undefined,
    note: undefined
    };
    this.currentIndex = -1;

    this.navireService.findByName(this.nom)
      .subscribe({
        next: (data) => {
          this.navires = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }

}
