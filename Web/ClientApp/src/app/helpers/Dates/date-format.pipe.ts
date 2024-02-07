import { DatePipe } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';
import { Constants } from '../../util/constants';

@Pipe({
  name: 'dateFormat_pipe',
})
export class DateFormatPipe extends DatePipe implements PipeTransform {
  override transform(value: any): any {
    return super.transform(value, Constants.DATE_FMT);
  }
}
