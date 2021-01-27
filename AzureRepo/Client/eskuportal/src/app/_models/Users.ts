import { country } from './country';
export interface Users{

  usersID :number;
  windowsID:string;
  countryID:number;
  contactNumber:number;
  department:string;
  email:string;
  userName:string;
  supervisorID :number;
  lastLoginDate:string;
  creationDate:string;
  createdBy:string;
  comment:string;
  isActive:boolean;
  terminationDate:string;
  superAdmin:boolean;
  country:country;


}
