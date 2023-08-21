import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNavireComponent } from './add-navire.component';

describe('AddProductComponent', () => {
  let component: AddNavireComponent;
  let fixture: ComponentFixture<AddNavireComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddNavireComponent]
    });
    fixture = TestBed.createComponent(AddNavireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
