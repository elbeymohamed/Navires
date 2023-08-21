import { Validators } from '@angular/forms';

export class Navire {
 
  numero: any;
 // @Validators.required
  nom: string | undefined;
  annee: any;
  //@Validators.required
  longueur: any;
  //@Validators.required
  largeur: any;
  tonnageBrut: any;
  tonnageNet: any;
 // @Validators.required
  note: string | undefined;
}
