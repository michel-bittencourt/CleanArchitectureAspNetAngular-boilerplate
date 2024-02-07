import { DatePipe } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';
import { Constants } from '../../util/constants';

@Pipe({
  name: 'dateTimeFormat_pipe',
})
export class DateTimeFormatPipe extends DatePipe implements PipeTransform {
  override transform(value: any): any {
    return super.transform(value, Constants.DATE_TIME_FMT);
  }
}
