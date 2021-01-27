import { userRole } from './userRole';
import { country } from './country';
export interface UserRoleMap{
  userRoleMapID:number;
  usersID:number;
  userRoleID:number;
  countryID:number;
  country:country;
  userRole:userRole;

}
